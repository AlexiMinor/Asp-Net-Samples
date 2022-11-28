import { ArticleService } from './../services/article/article.service';
import { Component, Input, OnInit } from '@angular/core';
import { Article } from '../models/article';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';


@Component({
  selector: 'app-article-details',
  templateUrl: './article-details.component.html',
  styleUrls: ['./article-details.component.scss']
})

export class ArticleDetailsComponent implements OnInit  {
  article: Article | undefined;

  constructor(private articleService: ArticleService,
    private route: ActivatedRoute,
    private location: Location) { }

  ngOnInit(): void {
    const id  = this.route.snapshot.paramMap.get('id') || '';
    this.articleService.getArticleByIdFromApi(id)
      .subscribe(article => this.article = article);
  }

  goBack(): void {
    this.location.back();
  }
}
