import { ApiService } from './../api.service';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/models/user';
import { BehaviorSubject, map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private userSubject?: BehaviorSubject<User | null>;
  public user?: Observable<User | null>;

  constructor(private router: Router, private apiService: ApiService) {
    this.userSubject = new BehaviorSubject<User | null>(
      JSON.parse(localStorage.getItem('user')!)
    );
    this.user = this.userSubject.asObservable();
  }

  public get userValue() {
    return this.userSubject?.value;
  }

  login(username: string, password: string) {
    return this.apiService.post('Token', { email: username, password }).pipe(
      map((user) => {
        localStorage.setItem('user', JSON.stringify(user));
        this.userSubject?.next(user);
        return user;
      })
    );
  }

  refreshToken(refreshToken: string) {
    return this.apiService.post('Token/Refresh', { refreshToken }).pipe(
      map((user) => {
        localStorage.setItem('user', JSON.stringify(user));
        this.userSubject?.next(user);
        return user;
      })
    );
  }

  logout() {
    localStorage.removeItem('user');
    this.userSubject?.next(null);
    this.router.navigateByUrl('/login');
  }
}
