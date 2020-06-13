import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'danger-alert',
  templateUrl: './danger-alert.component.html',
  styleUrls: ['./danger-alert.component.css']
})
export class DangerAlertComponent implements OnInit {

  @Input()
  message: string | null;

  constructor() { }

  ngOnInit(): void {
  }

}
