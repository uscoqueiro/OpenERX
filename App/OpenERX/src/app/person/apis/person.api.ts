import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Person } from '../models/person';

@Injectable({ providedIn: 'root' })
export class PersonApi {
  constructor() {
  }

  getPerson(id: string | null = null): Observable<Person | null> {
    return new Observable(observer => {
      this.listPersons().subscribe({
        next: (result: Person[]) => {

          for (const item of result) {
            if (item.id == id) {
              observer.next(item);
              observer.complete();
              return;
            }
          }

          observer.next(null);
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
    const items: Person[] = [
      {
        id: '1',
        name: 'Maria',
        identity: '123456987',
        enabled: true,
        type: '',
        attributes: [
          'Python',
          'JavaScript',
          'Java',
          'C#',
          'PHP',
          'Ruby'
        ]
      },
      {
        id: '2',
        name: 'João',
        identity: '987564232',
        enabled: true,
        type: '',
        attributes: [
          'Python',
          'C#',
          'PHP',
          'Ruby'
        ]
      },
      {
        id: '3',
        name: 'Roberto',
        identity: '14235656',
        enabled: true,
        type: '',
        attributes: [
          'Python'
        ]
      }
    ]

    return of(items);
  }
}
