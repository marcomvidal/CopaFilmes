import { Component, OnInit, Input } from '@angular/core';
import { Link } from './Link';

@Component({
  selector: 'breadcrumb-bar',
  templateUrl: './breadcrumb-bar.component.html',
  styleUrls: ['./breadcrumb-bar.component.css']
})
export class BreadcrumbBarComponent implements OnInit {

  @Input()
  links: Link[];

  constructor() { }

  ngOnInit(): void {
  }

}
