import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Article } from '../models/article';
import {MatCardModule} from '@angular/material/card';

@Component({
  selector: 'app-article-preview',
  templateUrl: './article-preview.component.html',
  styleUrls: ['./article-preview.component.scss']
})
export class ArticlePreviewComponent {
  @Input() article?: Article;
  @Output() selectedArticleFromPreview = new EventEmitter<Article>();

  isFocused: boolean = false;

  onSelect(article: Article) {
    this.selectedArticleFromPreview.emit(article);
  }

  onHover(){
    this.isFocused = true;
  }
}
