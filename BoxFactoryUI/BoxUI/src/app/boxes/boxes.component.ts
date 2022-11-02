import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../services/http.service";
import {Router} from "@angular/router";

interface Box{
  boxName: string;
  price: number;
}

@Component({
  selector: 'app-boxes',
  templateUrl: './boxes.component.html',
  styleUrls: ['./boxes.component.css']
})
export class BoxesComponent implements OnInit{
  boxName: string = "";
  boxPrice: number = 0;
  boxes: Box[] | any;
  constructor(private http: HttpService, private router: Router) {

  }

  async ngOnInit() {
    const products = await this.http.getBox();
    this.boxes = products;
  }

  nextPage(box : Box){
    this.router.navigate(['./box'])
  }

  writeProductName() {
    console.log(this.boxName)
  }
}
