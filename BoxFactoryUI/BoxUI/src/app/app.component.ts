import {Component, OnInit} from '@angular/core';
import {HttpService} from "../services/http.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  boxName: string = "";
  constructor(private http: HttpService) {

  }

  async ngOnInit() {
    const products = await this.http.getBox();
    console.log(products);
  }

  writeProductName() {
    console.log(this.boxName)
  }
}
