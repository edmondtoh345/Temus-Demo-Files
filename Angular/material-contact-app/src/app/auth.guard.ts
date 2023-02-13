import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable, map, catchError, throwError } from 'rxjs';
import { DataService } from './services/data.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private route: Router, private service: DataService) { }
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    return this.service.isTokenValid().pipe(map((data: any)=>{
      if(data.isAuthenticated){
        return true;
      }
      return false;
    }), catchError((err: HttpErrorResponse)=>{
      this.route.navigateByUrl('/login');
      return throwError(err);
    }))
  }

}
