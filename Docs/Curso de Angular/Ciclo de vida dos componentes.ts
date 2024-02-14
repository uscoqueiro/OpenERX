import { Component, OnInit, OnChanges, OnDestroy, DoCheck, AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked } from '@angular/core';

@Component({
  selector: 'app-exemplo',
  template: '<p>Exemplo de Componente</p>',
})
export class ExemploComponent implements OnInit, OnChanges, OnDestroy, DoCheck, AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked {
  // Propriedades e métodos do componente

  ngOnInit() {
    console.log('ngOnInit foi chamado');
  }

  ngOnChanges(changes: SimpleChanges) {
    console.log('ngOnChanges foi chamado', changes);
  }

  ngDoCheck() {
    console.log('ngDoCheck foi chamado');
  }

  ngAfterContentInit() {
    console.log('ngAfterContentInit foi chamado');
  }

  ngAfterContentChecked() {
    console.log('ngAfterContentChecked foi chamado');
  }

  ngAfterViewInit() {
    console.log('ngAfterViewInit foi chamado');
  }

  ngAfterViewChecked() {
    console.log('ngAfterViewChecked foi chamado');
  }

  ngOnDestroy() {
    console.log('ngOnDestroy foi chamado');
  }
}