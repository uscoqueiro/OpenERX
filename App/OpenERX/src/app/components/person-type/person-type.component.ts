import { Component, Input, ViewEncapsulation, Output, EventEmitter, forwardRef } from '@angular/core';
import { AbstractControl, ControlValueAccessor, NG_VALIDATORS, NG_VALUE_ACCESSOR, ValidationErrors, Validator } from '@angular/forms';

@Component({
  selector: 'app-person-type',
  templateUrl: './person-type.component.html',
  encapsulation: ViewEncapsulation.None,
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => PersonTypeComponent),
      multi: true,
    },
    {
      provide: NG_VALIDATORS,
      multi: true,
      useExisting: PersonTypeComponent
  }
  ]
})
export class PersonTypeComponent implements ControlValueAccessor, Validator {

  @Input() required: boolean = false;
  type: string | null = null;

  disabled: boolean = false;
  onChanged: any = () => { };
  onTouched: any = () => { };
  onValidationChange: () => void;

  constructor(
  ) {
  }

  validate(_control: AbstractControl<any, any>): ValidationErrors | null {
    if (!this.type && this.required)
      return { required: true };

    return null;
  }

  registerOnValidatorChange?(fn: () => void): void {
    this.onValidationChange = fn;
  }

  writeValue(obj: any): void {
    this.type = obj;
  }

  registerOnChange(fn: any): void {
    this.onChanged = fn;
  }

  registerOnTouched(fn: any): void {
    this.onTouched = fn;
  }

  setDisabledState(disabled: boolean): void {
    this.disabled = disabled;
  }

  setChange() {
    if (this.disabled) return;
    this.onChanged(this.type);
    this.onTouched();
  }

  blur() {
    if (this.disabled) return;
    this.onTouched();
  }
}
