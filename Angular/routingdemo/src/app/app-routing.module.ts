import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { AuthGuard } from './auth.guard';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';
import { NotfoundComponent } from './notfound/notfound.component';
import { PostsComponent } from './posts/posts.component';
import { ProfileComponent } from './profile/profile.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'about', component: AboutComponent, canActivate:[AuthGuard]},
  {path: 'contact', component: ContactComponent},
  {path: 'profile/:id', canActivate: [AuthGuard], component: ProfileComponent, children: [{
    path: 'posts', component: PostsComponent
  }]},
  {path: '**', component: NotfoundComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
