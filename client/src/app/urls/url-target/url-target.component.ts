import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UrlsService } from 'src/app/services/urls.service';

@Component({
  selector: 'app-url-target',
  templateUrl: './url-target.component.html',
  styleUrls: ['./url-target.component.scss']
})
export class UrlTargetComponent implements OnInit {
  text: string = "";

  constructor(private http: HttpClient, private route: ActivatedRoute, private urlsService: UrlsService) {}

  ngOnInit(): void {
    this.text = this.route.snapshot.paramMap.get('text') ?? "";
    this.goToTarget(this.text);
  }

  goToTarget(text: string) {
    this.urlsService.goToTarget(text).subscribe(response => {
      document.location.href = response;
    });
  }
}
