import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../services/http.service";
import {Router} from "@angular/router";

interface Order{
  totalPrice: number;
  status: string;
  customerID: number;
  isDone: boolean;
}

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {
  totalPrice : string = "";
  status : string = "";
  customerID: number = 0;
  isDone: boolean = false;
  id: number = 0;
  date: string = "";
  orders: Order[] | any;
  constructor(private http: HttpService, private router: Router) { }

  async ngOnInit(){
    const products = await this.http.getOrder();
    this.orders = products;
  }

  async CreateOrder(){
    let Order = {
      totalPrice : this.totalPrice,
      status : this.status,
      customerID : this.customerID,
      isDone : this.isDone,
      date : this.date,
      id : this.id
    }
    await this.http.createOrder(Order)
  }
}
