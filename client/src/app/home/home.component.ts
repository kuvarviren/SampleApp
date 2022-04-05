import { Component, OnInit } from '@angular/core';
import { GreetingService } from '../_services/greeting.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  form:any = {};
  greetingMessage:any = {name:''};
  constructor(private greetingService:GreetingService) { }

  ngOnInit(): void {
  }
  getMessage(msg:string) {
    this.greetingService.getMesage(msg).subscribe({
      next: (response) => {
        this.greetingMessage = response;
      },
      error: (error) => console.log(error)
    });
  }
  onClickSubmit(form:any){
    const msg = (form.name === null || form.name === undefined) ? '' : form.name;
    this.getMessage(msg);
  }
}
