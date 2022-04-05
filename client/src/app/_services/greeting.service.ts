import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GreetingService {
  baseUrl = 'https://localhost:5001/api/';
  constructor(private http:HttpClient) { }
  getMesage(message:string){
    return this.http.get(this.baseUrl + "users/greet?name=" + message);
  }
}
