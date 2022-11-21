import { ARTCILES } from './../data/articles';
import { Article } from './../models/article';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss'],
})
export class ArticlesComponent implements OnInit {
  articles?: Article[]=[];
  selectedArticle?: Article;

  ngOnInit(): void {
   this.articles = ARTCILES;
  }

  onSelect(article: Article): void {
    this.selectedArticle = article;

  }
}
