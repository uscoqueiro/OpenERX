

import { Component, ViewEncapsulation, forwardRef, Output, EventEmitter } from "@angular/core";
import { NG_VALUE_ACCESSOR, NG_VALIDATORS, ControlValueAccessor, Validator, AbstractControl, ValidationErrors } from "@angular/forms";


@Component({
    selector: 'attribute-select',
    templateUrl: './attribute-select.component.html',
    encapsulation: ViewEncapsulation.None,

    providers: [
        {
            provide: NG_VALUE_ACCESSOR,
            useExisting: forwardRef(() => AttributeSelectComponent),
            multi: true
        },
        {
            provide: NG_VALIDATORS,
            multi: true,
            useExisting: AttributeSelectComponent
        }
    ]

})

export class AttributeSelectComponent implements  ControlValueAccessor, Validator {


    @Output() blur = new EventEmitter<any>();

    value: string | null = null;
    disabled: boolean = false;
    onChanged: any = () => { };
    onTouched: any = () => { };


    constructor(
    ) {
        // this._service.data$
        //     .pipe(takeUntilDestroyed())
        //     .subscribe(result => {

        //     });
    }

    ngOnInit(): void {

    }



    validate(_control: AbstractControl<any, any>): ValidationErrors  {
        let validation = {};
        // if (!this.value && this.required)
        //     validation = { required: true };

        return validation;
    }

    onValidationChange: () => void;

    registerOnValidatorChange?(fn: () => void): void {
        this.onValidationChange = fn;
    }

    writeValue(value: any): void {
        this.value = value;
    }

    registerOnChange(fn: any): void {
        this.onChanged = fn;
    }

    registerOnTouched(fn: any): void {
        this.onTouched = fn;
    }

    setDisabledState?(disabled: boolean): void {
        this.disabled = disabled;
    }

    setChange() {
        if (this.disabled) return;
        this.onChanged(this.value);
        this.onTouched();
    }

    setBlur() {
        this.onTouched();
        this.onValidationChange();
        this.blur.emit(this.value);
    }


}
