import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TitleComponent } from './title/title.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ReversePipe } from './pipes/custom.pipe';
import { CommonModule } from '@angular/common';
import { PersonListComponent } from './person/list/list.component';
import { PersonRegisterComponent } from './person/register/register.component';
import { PersonTypeComponent } from './components/person-type/person-type.component';

@NgModule({
  declarations: [
    AppComponent,
    TitleComponent,
    PersonListComponent,
    PersonRegisterComponent,
    PersonTypeComponent,
    ReversePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
