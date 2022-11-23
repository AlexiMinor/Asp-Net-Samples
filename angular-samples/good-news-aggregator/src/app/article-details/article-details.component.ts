import { Component, Input } from '@angular/core';
import { Article } from '../models/article';

@Component({
  selector: 'app-article-details',
  templateUrl: './article-details.component.html',
  styleUrls: ['./article-details.component.scss']
})

export class ArticleDetailsComponent {
  @Input() article?: Article;


}
