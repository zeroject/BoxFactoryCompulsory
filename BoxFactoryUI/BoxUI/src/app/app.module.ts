import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatInputModule} from "@angular/material/input";
import {FormsModule} from "@angular/forms";
import {MatButtonModule} from "@angular/material/button";
import {MatCardModule} from "@angular/material/card";
import { HomescreenComponent } from './homescreen/homescreen.component';
import { CustomersComponent } from './customers/customers.component';
import { OrdersComponent } from './orders/orders.component';
import { BoxesComponent } from './boxes/boxes.component';
import {MatRadioModule} from "@angular/material/radio";
import {MatBottomSheetModule} from "@angular/material/bottom-sheet";
import {RouterModule, Routes} from "@angular/router";
import {MatButtonToggleModule} from "@angular/material/button-toggle";

const routes: Routes = [
  {
    path: 'box', component: BoxesComponent
  },
  {
    path: 'home', component: HomescreenComponent
  },
  {
    path: '**', redirectTo: 'home'
  }
]

@NgModule({
  declarations: [
    AppComponent,
    HomescreenComponent,
    CustomersComponent,
    OrdersComponent,
    BoxesComponent
  ],
  imports: [
    RouterModule.forRoot(routes),
    BrowserModule,
    BrowserAnimationsModule,
    MatInputModule,
    FormsModule,
    MatButtonModule,
    MatCardModule,
    MatRadioModule,
    MatBottomSheetModule,
    MatButtonToggleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
