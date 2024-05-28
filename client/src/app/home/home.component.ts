import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  registerMode = false;
  users: any;

  constructor() {}

  ngOnInit(): void {
    //this.getUsers();
  }

  registerToggle() {
    this.registerMode = !this.registerMode
  }

  // getUsers() {
  //   this.http.get('http://localhost:5211/api/users').subscribe({
  //     next: response => this.users = response,
  //     error: error => console.log(error),
  //     complete: () => console.log('Requst has completed')
  //   })
  // }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }
}
