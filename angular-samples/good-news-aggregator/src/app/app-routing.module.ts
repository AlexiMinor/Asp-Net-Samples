import { LoginComponent } from './login/login.component';
import { ArticleDetailsComponent } from './article-details/article-details.component';
import { TopRatedArticlesComponent } from './top-rated-articles/top-rated-articles.component';
import { AppComponent } from './app.component';
import { ArticlesComponent } from './articles/articles.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  {path:'', component: TopRatedArticlesComponent, pathMatch:'full'},
  {path: 'articles', component:ArticlesComponent},
  {path:'articles/:id', component:ArticleDetailsComponent, canActivate: [AuthGuard] },
  {path:'login', component:LoginComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
