import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../services/http.service";
import {Router} from "@angular/router";

interface CustommerDTO{
  name: string;
  lastName: string;
  companyName: string;
}
interface Custommer{
  id: number;
  name: string;
  lastName: string;
  email: string;
  companyName: string;
  phoneNumber: number;
}

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  id: number = 0;
  name: string = "";
  lastName: string = "";
  eMail: string="";
  companyName: string="";
  phoneNumber: number = 0;
  custommers: CustommerDTO[] | any;

  constructor(private http: HttpService, private router: Router) { }

  async ngOnInit() {
    const products = await this.http.getCustommer();
    this.custommers = products;
  }

  async CreateCustomer(){
    let Custommer = {
      id : this.id,
      name : this.name,
      lastName : this.lastName,
      eMail : this.eMail,
      companyName : this.companyName,
      phoneNumber : this.phoneNumber,
    }
    await this.http.createCustommer(Custommer)
  }

}
