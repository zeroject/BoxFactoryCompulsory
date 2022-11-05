import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../services/http.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(public http: HttpService, private router: Router) { }

  ngOnInit(): void {
  }

  orderClick(){
    this.router.navigate(['./order'])
  }

  UsersClick(){
    this.router.navigate(['./user'])
  }

  BoxClick(){
    this.router.navigate(['./box'])
  }

}
