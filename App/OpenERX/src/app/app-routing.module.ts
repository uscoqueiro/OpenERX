import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonListComponent } from './person/list/list.component';
import { PersonRegisterComponent } from './person/register/register.component';

const routes: Routes = [
  {
    path: 'list',
    component: PersonListComponent,
  },
  {
    path: 'create',
    component: PersonRegisterComponent
  },
  {
    path: ':id/edit',
    component: PersonRegisterComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
