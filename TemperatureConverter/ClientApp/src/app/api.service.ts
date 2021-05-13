import { Injectable } from '@angular/core';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TemperatureOutputModel } from './models/tempOutputModel';
import { ApiResponse } from './models/apiResponse';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  public convertTemperature(model :TemperatureOutputModel) {
    return this.http.post<ApiResponse>(this.baseUrl + 'api/temperatureConverter/convertTemperature', model);
  }

}
