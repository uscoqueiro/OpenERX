import { Component, OnDestroy, ViewEncapsulation } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { PersonService } from '../services/person.service';
import { Person } from '../models/person';

@Component({
  selector: 'app-person-register',
  templateUrl: './register.component.html',
  encapsulation: ViewEncapsulation.None
})
export class PersonRegisterComponent implements OnDestroy {

  title: string | null = "Cadastro de Pessoa";
  action: 'edit' | 'create' | 'loading' = 'loading';
  unsubscribeAll: Subject<any> = new Subject<any>();

  person = {} as Person;

  constructor(
    private _activatedRoute: ActivatedRoute,
    private _personService: PersonService) {

    this.person.name = "XPRP";
    this.person.type = "PF";

    this._activatedRoute.params
      .pipe(takeUntil(this.unsubscribeAll))
      .subscribe(params => {
        const id = params['id'];

        if (!id) {
          this.action = 'create';
        }
        else {
          this._personService.getPerson(id)
            .subscribe({
              next: () => {
                this.action = 'edit';
              }
            });
        }
      });
  }

  save() {

  }

  ngOnDestroy(): void {
    this.unsubscribeAll.next(null);
    this.unsubscribeAll.complete();

  }
}
