import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../services/http.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-homescreen',
  templateUrl: './homescreen.component.html',
  styleUrls: ['./homescreen.component.css']
})
export class HomescreenComponent implements OnInit {
  email: any;
  password: any;

  constructor(public http: HttpService, private router: Router) { }

  ngOnInit(): void {
  }

  enter(){
    this.router.navigate(['./home'])
  }

}
