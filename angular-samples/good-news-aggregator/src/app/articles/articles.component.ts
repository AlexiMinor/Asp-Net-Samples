import { Article } from './../models/article';
import { Component, OnInit } from '@angular/core';
import { ArticleService } from '../services/article/article.service';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss'],
})
export class ArticlesComponent implements OnInit {
  articles?: Article[]=[];
  selectedArticle?: Article;

  constructor(private articleService: ArticleService) { }

  ngOnInit(): void {
   this.articleService.getAllArticlesFromApi().subscribe(articles => this.articles = articles);
  };

  viewArticle(article: Article): void {
    this.selectedArticle = article;
  };
}
