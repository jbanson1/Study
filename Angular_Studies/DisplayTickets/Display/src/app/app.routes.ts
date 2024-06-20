import { Routes } from '@angular/router';
import { provideRouter } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { DeskComponent } from './desk/desk.component';

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'about', component: AboutComponent },
    { path: '', component: DeskComponent }
];

export const appRoutingProviders = [
    provideRouter(appRoutes)
  ];