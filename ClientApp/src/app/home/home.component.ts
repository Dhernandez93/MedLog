import { DOCUMENT } from '@angular/common';
import { Component, Inject, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AppComponent } from '../app.component';
import { ApiConsume } from '../shared/api-consume.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  constructor(public service: ApiConsume, private router: Router) {
  }
    ngOnInit(): void {
    }
    
  public Buscar() {
    this.service.getEirDetail().subscribe(result => {
      this.service.data = result;
      console.log(this.service.data);
    }, error => console.error(error));
    
    this.router.navigateByUrl('/Datos');
  }

}



