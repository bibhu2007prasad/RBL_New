import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-allumrn',
  templateUrl: './allumrn.component.html',
  styleUrls: ['./allumrn.component.css']
})
export class AllumrnComponent implements OnInit {
    showModal: boolean;
    showModal1: boolean;
    onClick(event) {
        this.showModal = true;
    }
    onClick1(event) {
        this.showModal1 = true;
    }
    hide() {
        this.showModal = false;
        this.showModal1 = false;
    }


  ngOnInit() {
  }

}
