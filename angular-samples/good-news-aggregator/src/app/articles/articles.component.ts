import { Article } from './../models/article';
import { Component, OnInit } from '@angular/core';
import { ArticleService } from '../services/article/article.service';
import { ActivatedRoute } from '@angular/router';
import { forkJoin } from 'rxjs';
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss'],
})
export class ArticlesComponent implements OnInit {
  articles: Article[]=[];
  showSpinner: Boolean = false;
  actualPage: number = 0;
  articlesNumber: number=0;
  pageEvent?: PageEvent;
  pageSize:number = 5;
  length?:number;


  constructor(private articleService: ArticleService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.showSpinner = true;

    const sourses = [
      this.articleService.getArticlesCountFromApi(),
      this.articleService.getArticlesFromApi(this.pageSize, this.actualPage)
    ];

    forkJoin(sourses).subscribe(results => {
      this.articlesNumber = Number(results[0])
      this.articles = results[1] as Article[];
    }).add(() => {
      this.showSpinner = false;
    });;

    this.actualPage = Number(this.route.snapshot.paramMap.get('page')) || 0;
    console.log(this.actualPage);
  };

  getServerData(event?:PageEvent){
    this.articleService.getArticlesFromApi(this.pageSize, this.actualPage).subscribe(articles =>{
      this.articles = articles;
      this.pageEvent = event;

      return this.pageEvent;
    }
    );
  }

}
