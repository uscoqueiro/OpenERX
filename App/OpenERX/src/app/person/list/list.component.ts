import { Component } from '@angular/core';
import { PersonService } from '../services/person.service';
import { Person } from '../models/person';

@Component({
  selector: 'app-person-list',
  templateUrl: './list.component.html'
})
export class PersonListComponent {

  title: string | null = "Lista de Pessoas";

  items: Person[] = [];

  constructor(private _personService: PersonService) {
    this._personService.listPersons().subscribe({
      next: (result: Person[]) => {
        this.items = result;
      }
    });
  }


}
