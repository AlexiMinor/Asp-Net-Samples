import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Article } from '../models/article';

@Component({
  selector: 'app-article-preview',
  templateUrl: './article-preview.component.html',
  styleUrls: ['./article-preview.component.scss']
})
export class ArticlePreviewComponent {
  @Input() article?: Article;
  @Output() selectedArticleFromPreview = new EventEmitter<Article>();


  onSelect(article: Article) {
    this.selectedArticleFromPreview.emit(article);
  }
}
