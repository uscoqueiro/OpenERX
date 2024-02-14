import { AfterContentChecked, AfterContentInit, AfterViewChecked, AfterViewInit, Component, DoCheck, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss']
})
export class TitleComponent   {
// export class TitleComponent implements OnChanges, OnInit, DoCheck,
//   AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked, OnDestroy {

  @Input() text: string = '';
  @Input() note: string = '';

  constructor() {

      text: "Xpto"


  }



  // ngOnChanges(changes: SimpleChanges): void {
  //   // console.log('ngOnChanges');
  // }

  // ngOnInit(): void {
  //   console.log('ngOnInit');
  // }

  // ngDoCheck(): void {
  //   console.log('ngDoCheck');
  // }




  // ngAfterContentInit(): void {
  //   console.log('ngAfterContentInit');
  // }
  // ngAfterContentChecked(): void {
  //   console.log('ngAfterContentChecked');
  // }
  // ngAfterViewInit(): void {
  //   console.log('ngAfterViewInit');
  // }
  // ngAfterViewChecked(): void {
  //   console.log('ngAfterViewChecked');
  // }

  // ngOnDestroy(): void {
  //   console.log('ngOnDestroy');
  // }


}
