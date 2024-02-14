import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { PersonApi } from "../apis/person.api";
import { Person } from "../models/person";


@Injectable({ providedIn: 'root' })
export class PersonService {

  persons: Person[] = [];
  person = {} as Person;

  constructor(private _api: PersonApi) {

  }

  getPerson(id: string | null = null): Observable<Person | null> {
    return new Observable(observer => {
      this._api.getPerson(id).subscribe({
        next: (result: Person | null) => {
          observer.next(result);
          observer.complete();

        },
        error: (error: any) => {
          observer.error(error);
          observer.complete();
        }
      });
    });
  }


  listPersons(): Observable<Person[]> {
    return new Observable(observer => {
      this._api.listPersons().subscribe({
        next: (result: Person[]) => {
          this.persons = result;
          observer.next(result);
          observer.complete();

        },
        error: (error: any) => {
          observer.error(error);
          observer.complete();
        }
      });
    });
  }

  // create(): Observable<any> {

  // }

  // edit(id: string): Observable<any> {

  // }

}
