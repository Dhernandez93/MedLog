import { Component } from '@angular/core';
import { ApiConsume } from '../shared/api-consume.service';

@Component({
  selector: 'app-loader-component',
  templateUrl: './loader.component.html'
})
export class LoaderComponent {

  constructor(public service: ApiConsume) {

  }

}
