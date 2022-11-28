import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopRatedArticlesComponent } from './top-rated-articles.component';

describe('TopRatedArticlesComponent', () => {
  let component: TopRatedArticlesComponent;
  let fixture: ComponentFixture<TopRatedArticlesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopRatedArticlesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TopRatedArticlesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
