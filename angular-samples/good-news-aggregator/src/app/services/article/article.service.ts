import { ApiService } from './../api.service';
import { Observable, of } from 'rxjs';
import { Injectable } from '@angular/core';
import { Article } from 'src/app/models/article';

@Injectable({
  providedIn: 'root'
})

export class ArticleService {

  constructor(private apiService: ApiService) { }

  // getArticles() : Observable<Article[]> {
  //   let articles = [
  //     {
  //       id: '1b9d6bcd-bbfd-4b2d-9b5d-ab8dfbbd4bed',
  //       title: 'Some very good article #1',
  //       description: 'Some very good article description',
  //       rate: 3,
  //       text: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eleifend interdum eros, at pharetra metus accumsan vitae. Proin placerat egestas elit non porttitor. Aliquam vitae ex tortor. Ut interdum rhoncus leo, ut pharetra ex mollis id. Nullam sem risus, volutpat at interdum ut, cursus eget ante. Aliquam lobortis tortor vel massa sagittis, eget sagittis lectus varius. Nullam sodales eros sit amet libero laoreet, et laoreet mi eleifend. Sed lacinia urna eget quam porta dapibus. Sed dui neque, malesuada non fermentum vel, vulputate a justo. Nunc commodo sagittis lacus, quis gravida metus pellentesque sit amet. Curabitur molestie turpis ac felis rutrum, vitae porta metus porta. Nam id tortor eu magna consequat cursus in id magna. Nunc lobortis pellentesque ante ut hendrerit. Nam accumsan faucibus velit, at molestie sapien maximus at. Vivamus justo lacus, egestas non finibus eu, molestie vitae erat. Morbi eu dictum mauris, facilisis convallis elit. Vestibulum pulvinar a leo ac elementum. Aenean et tellus nisl. Cras mi nunc, euismod aliquet pharetra sit amet, porttitor sit amet purus. Morbi tempus tortor et urna accumsan, mollis volutpat risus condimentum. Quisque ut rhoncus dui. In maximus sem metus, ut sollicitudin dolor porta sed. Aenean varius euismod dolor in ornare. Integer non auctor lectus. Nam id sapien ac tellus dignissim mollis pellentesque et magna. Nullam eleifend, ligula eu scelerisque vulputate, ex dui congue arcu, eget tempor tellus nisi id nibh. Sed molestie arcu mauris, at scelerisque nisi suscipit non. Duis diam diam, placerat in luctus pharetra, rhoncus id dolor.',
  //       publicationDate: new Date()
  //     },
  //     {
  //       id: '1b9d6bcd-bbfd-4b2d-9b5d-ab8dfbbd4bec',
  //       title: 'Some very good article #2',
  //       description: 'Some very good article description',
  //       rate: 3,
  //       text: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eleifend interdum eros, at pharetra metus accumsan vitae. Proin placerat egestas elit non porttitor. Aliquam vitae ex tortor. Ut interdum rhoncus leo, ut pharetra ex mollis id. Nullam sem risus, volutpat at interdum ut, cursus eget ante. Aliquam lobortis tortor vel massa sagittis, eget sagittis lectus varius. Nullam sodales eros sit amet libero laoreet, et laoreet mi eleifend. Sed lacinia urna eget quam porta dapibus. Sed dui neque, malesuada non fermentum vel, vulputate a justo. Nunc commodo sagittis lacus, quis gravida metus pellentesque sit amet. Curabitur molestie turpis ac felis rutrum, vitae porta metus porta. Nam id tortor eu magna consequat cursus in id magna. Nunc lobortis pellentesque ante ut hendrerit. Nam accumsan faucibus velit, at molestie sapien maximus at. Vivamus justo lacus, egestas non finibus eu, molestie vitae erat. Morbi eu dictum mauris, facilisis convallis elit. Vestibulum pulvinar a leo ac elementum. Aenean et tellus nisl. Cras mi nunc, euismod aliquet pharetra sit amet, porttitor sit amet purus. Morbi tempus tortor et urna accumsan, mollis volutpat risus condimentum. Quisque ut rhoncus dui. In maximus sem metus, ut sollicitudin dolor porta sed. Aenean varius euismod dolor in ornare. Integer non auctor lectus. Nam id sapien ac tellus dignissim mollis pellentesque et magna. Nullam eleifend, ligula eu scelerisque vulputate, ex dui congue arcu, eget tempor tellus nisi id nibh. Sed molestie arcu mauris, at scelerisque nisi suscipit non. Duis diam diam, placerat in luctus pharetra, rhoncus id dolor.',
  //       publicationDate: new Date()
  //     },
  //     {
  //       id: '1b9d6bcd-bbfd-4b2d-9b5d-ab8dfbbd4bea',
  //       title: 'Some very good article #3',
  //       description: 'Some very good article description',
  //       rate: 3,
  //       text: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eleifend interdum eros, at pharetra metus accumsan vitae. Proin placerat egestas elit non porttitor. Aliquam vitae ex tortor. Ut interdum rhoncus leo, ut pharetra ex mollis id. Nullam sem risus, volutpat at interdum ut, cursus eget ante. Aliquam lobortis tortor vel massa sagittis, eget sagittis lectus varius. Nullam sodales eros sit amet libero laoreet, et laoreet mi eleifend. Sed lacinia urna eget quam porta dapibus. Sed dui neque, malesuada non fermentum vel, vulputate a justo. Nunc commodo sagittis lacus, quis gravida metus pellentesque sit amet. Curabitur molestie turpis ac felis rutrum, vitae porta metus porta. Nam id tortor eu magna consequat cursus in id magna. Nunc lobortis pellentesque ante ut hendrerit. Nam accumsan faucibus velit, at molestie sapien maximus at. Vivamus justo lacus, egestas non finibus eu, molestie vitae erat. Morbi eu dictum mauris, facilisis convallis elit. Vestibulum pulvinar a leo ac elementum. Aenean et tellus nisl. Cras mi nunc, euismod aliquet pharetra sit amet, porttitor sit amet purus. Morbi tempus tortor et urna accumsan, mollis volutpat risus condimentum. Quisque ut rhoncus dui. In maximus sem metus, ut sollicitudin dolor porta sed. Aenean varius euismod dolor in ornare. Integer non auctor lectus. Nam id sapien ac tellus dignissim mollis pellentesque et magna. Nullam eleifend, ligula eu scelerisque vulputate, ex dui congue arcu, eget tempor tellus nisi id nibh. Sed molestie arcu mauris, at scelerisque nisi suscipit non. Duis diam diam, placerat in luctus pharetra, rhoncus id dolor.',
  //       publicationDate: new Date()
  //     }
  //   ];

  //   return of(articles);
  // }

  getAllArticlesFromApi(): Observable<Article[]>{
    return this.apiService.get('Articles', {}).pipe();
  }

  getArticleByIdFromApi(id:string): Observable<Article>{
    return this.apiService.get(`Articles/${id}`, {}).pipe();
  }

  getOnlinerArticlesFromApi(): Observable<Article[]>{
    return this.apiService.get('Articles', {
      sourceId: "02cff32a-097a-48b4-8240-f27f81e8a0c1",
      pageSize:5,
      pageNumber:0}).pipe();
  }
}
