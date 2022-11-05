import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../services/http.service";
import {Router} from "@angular/router";

interface DtoBox{
  boxName: string;
  price: number;
  boxOrderNum : number;
}

interface Box{
  boxName : string,
  boxDesc : string,
  boxWidth : number,
  boxHeight : number,
  boxDepth : number,
  price : number,
  isFolded : boolean,
  orderID : number
}

@Component({
  selector: 'app-boxes',
  templateUrl: './boxes.component.html',
  styleUrls: ['./boxes.component.css']
})
export class BoxesComponent implements OnInit{
  boxName: string = "";
  boxPrice: number = 0;
  boxOrderNum : number = 0;
  boxDescription : string = "";
  boxWidth : number = 0;
  boxHieght : number = 0;
  boxDepth : number = 0;
  isFolded : boolean = false;
  id : number = 0;
  boxes: DtoBox[] | any;
  constructor(private http: HttpService, private router: Router) {

  }

  async ngOnInit() {
    const products = await this.http.getBox();
    this.boxes = products;
  }

  async CreateBox(){
    let Box = {
      boxName : this.boxName,
      boxDescription : this.boxDescription,
      boxWidth : this.boxWidth,
      boxHieght : this.boxHieght,
      boxDepth : this.boxDepth,
      boxPrice : this.boxPrice,
      isFolded : this.isFolded,
      orderID : this.boxOrderNum,
      id : this.id
    }
    await this.http.createBox(Box)
  }

  nextPage(){
    this.router.navigate(['./box'])
  }

  writeProductName() {
    console.log(this.boxName)
  }
}
