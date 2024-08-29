import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ITodoItem } from '../models/ITodoItem';
import { FormsModule } from '@angular/forms';
import { NgArrayPipesModule } from 'ngx-pipes';
import { CommonModule, JsonPipe } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,FormsModule,NgArrayPipesModule,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent  {


  
todoList:ITodoItem[]=[];
title:string='';
id:number=1;
searchTerm:boolean=false;



addItem()
{
   let todoItem:ITodoItem=
   {
      id:this.id++,
      title : this.title,
      isCompleted:false
   }
   this.todoList.push(todoItem);
   this.title=''

   
   
}

removeItem(index: number) 
{
    this.todoList.splice(index,1);
}


}
