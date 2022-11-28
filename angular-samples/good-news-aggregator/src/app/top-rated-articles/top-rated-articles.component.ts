import { Component } from '@angular/core';
import { Article } from '../models/article';
import { ArticleService } from '../services/article/article.service';

@Component({
  selector: 'app-top-rated-articles',
  templateUrl: './top-rated-articles.component.html',
  styleUrls: ['./top-rated-articles.component.scss']
})
export class TopRatedArticlesComponent {
  articles?: Article[]=[];
  selectedArticle?: Article;

  constructor(private articleService: ArticleService) { }

  ngOnInit(): void {
   this.articleService.getOnlinerArticlesFromApi().subscribe(articles => this.articles = articles);
  };

  viewArticle(article: Article): void {
    this.selectedArticle = article;
  };
}
