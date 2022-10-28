import { Injectable } from '@angular/core';
import axios from "axios";

export const customAxios = axios.create({
  baseURL: 'http://localhost:5089'
})

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor() { }

  async getBox(){
    const httpResponse = await customAxios.get('Box');
    httpResponse.data;
  }
}
