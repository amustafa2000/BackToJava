import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { TaskComponent }   from './task.component';
@NgModule({
    imports:      [ BrowserModule ],
    declarations: [ TaskComponent ],
    bootstrap:    [ TaskComponent ]
})
export class TaskModule { }
