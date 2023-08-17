import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UrlTargetComponent } from './urls/url-target/url-target.component';

const routes: Routes = [
  {path: ':text', component: UrlTargetComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }