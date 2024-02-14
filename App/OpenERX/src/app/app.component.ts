import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormBuilder, FormGroup, NgForm, UntypedFormBuilder, UntypedFormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss',]
})

export class AppComponent {

  userForm!: FormGroup;

  // user = {
  //   email: '',
  //   name: '',
  //   age: 0,
  //   id: '',
  //   gender: '',
  //   newsletter: false
  // };


  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.buildForm();
  }

  buildForm() {
    this.userForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]],
      email: ['xpto@gmail.com', [Validators.required, Validators.email]],
      password: ['232323232323', [Validators.required, Validators.minLength(8)]],
    });
  }

  send() {
    console.log(this.userForm?.value.name);
  }

}

