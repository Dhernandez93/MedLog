import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Eir } from "./api-consume.model";

@Injectable({
  providedIn: 'root'
})
export class ApiConsume {

  constructor(private http: HttpClient) { }

  readonly baseUrl = 'https://localhost:5001/Eir/Consulta/';
  data: Eir = new Eir();

  getEirDetail() {
    return this.http.get<Eir>(this.baseUrl + this.data.eir);
  }
}
