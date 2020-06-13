import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.css'],
  host: { 'class': 'col-12' }
})
export class BannerComponent implements OnInit {

  @Input()
  title: string;

  @Input()
  description: string;

  constructor() { }

  ngOnInit(): void {
  }

}
