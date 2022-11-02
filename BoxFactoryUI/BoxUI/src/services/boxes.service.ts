import { Injectable } from '@angular/core';
import axios from "axios";

export const boxesAxios = axios.create({
  baseURL: 'http://localhost:5089'
})

@Injectable({
  providedIn: 'root'
})
export class BoxesService {

  constructor() { }

  async getBox(){
    const httpResponse = await  boxesAxios.get('Box');
    httpResponse.data;
  }
}
