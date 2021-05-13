import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { ApiService } from '../api.service';
import { TempratureFormats, TempratureTypes } from '../enum/TempEnum';
import { TemperatureOutputModel } from './../models/tempOutputModel';

@Component({
  selector: 'app-temperature-converter',
  templateUrl: './temperature-converter.component.html',
  styleUrls: ['./temperature-converter.component.css']
})
export class TemperatureConverterComponent implements OnInit {

  tempForm: FormGroup;
  formData = {
    tempType: 0,
    tempValue: '',
    resultTempType: 0
  }

  constructor(private form: FormBuilder, private apiService: ApiService, private ngxService: NgxUiLoaderService) {
    this.createForm();
  }

  createForm() {
    this.tempForm = this.form.group({
      tempType: ['0', [Validators.required, Validators.min(1)]],
      tempValue: ['', Validators.required],
      resultTempType: ['0', [Validators.required, Validators.min(1)]],
      resultTempValue: ['']
    });
  }

  ngOnInit() {
  }

  calculateTemperature() {
    if (this.tempForm.valid) {
      var format = this.tempForm.value.tempType + this.tempForm.value.resultTempType;
      this.getResult(format, this.tempForm.value.tempValue);
    } else {
      this.tempForm.controls["resultTempValue"].setValue(0);
    }
  }

  getResult(formatValue: any, temp: any) {

    const model: TemperatureOutputModel = {
      format: parseInt(formatValue),
      TempValue: parseFloat(temp)
    }

    this.ngxService.start();

    this.apiService.convertTemperature(model).subscribe(result => {
      this.tempForm.controls["resultTempValue"].setValue(result.data);
    }, error => console.error(error));

    this.ngxService.stop();
  }

}
