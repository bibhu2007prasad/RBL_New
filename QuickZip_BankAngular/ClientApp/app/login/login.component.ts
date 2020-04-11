import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormControl, Validators,FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    href1: string;
    LoginForm: FormGroup;
    constructor(private router: Router, private formBuilder: FormBuilder) { }

    ngOnInit() {
        this.href1 = this.router.url;
        this.LoginForm = this.formBuilder.group({
            UserName: ['', Validators.required],
            Password: ['', Validators.required]

        });
    }


    onSubmit() {
        this.router.navigate(['/dashboard']);
    }


}
