import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-link-setup',
  templateUrl: './link-setup.component.html',
  styleUrls: ['./link-setup.component.css']
})
export class LinkSetupComponent implements OnInit {

  constructor() { }
    showModal: boolean;
   
    onClick(event) {
        this.showModal = true;
    }
   
    hide() {
        this.showModal = false;

    }
  ngOnInit() {
  }

}
