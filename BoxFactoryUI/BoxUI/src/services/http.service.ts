import { Injectable } from '@angular/core';
import axios from "axios";
import {CustomersComponent} from "../app/customers/customers.component";

export const customAxios = axios.create({
  baseURL: 'https://localhost:7089'
})

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor() { }

  async getBox(){
    const httpResponse = await customAxios.get('Box');
    return httpResponse.data;
  }

  async getCustommer(){
    const httpResponse = await customAxios.get('Custommer');
    return httpResponse.data;
  }

  async createBox(box: { isFolded: boolean; boxDepth: number; boxPrice: number; orderID: number; boxName: string; boxDescription: string; boxWidth: number; boxHieght: number, id: number }){
    const httpResult = await customAxios.post<Box>('Box/CreateNewBox', box)
    return httpResult.data;
  }

  async createCustommer(custommer: { name: string, lastName: string, eMail: string, companyName: string, phoneNumber: number, id: number }){
    const httpResult = await customAxios.post<Custommer>('Custommer/CreateNewCustomer', custommer)
    return httpResult.data;
  }
}

interface Box{
  boxName : string,
  boxDesc : string,
  boxWidth : number,
  boxHeight : number,
  boxDepth : number,
  price : number,
  isFolded : boolean,
  orderID : number,
  id : number
}
interface Custommer{
  name : string,
  lastName : string,
  eMail : string,
  companyName : string,
  phoneNumber : number,
  id : number
}
