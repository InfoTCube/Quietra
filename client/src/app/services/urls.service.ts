import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UrlsService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  goToTarget(text: string) {
    return this.http.post(this.baseUrl + 'Url/' + text, {}, {responseType: 'text'});
  }
}
