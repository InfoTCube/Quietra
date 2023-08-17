import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { AppComponent } from './app.component';
import { UrlTargetComponent } from './urls/url-target/url-target.component';
import { AppRoutingModule } from './app-routing-module';

@NgModule({
  declarations: [
    AppComponent,
    UrlTargetComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
