import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { Patients } from './patients.model';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class PatientsService {
  url: string = environment.apiBaseUrl + '/Patients';
  list: Patients[] = [];
  formData: Patients = new Patients();
  constructor(private http: HttpClient) { }

  refreshList() {
    this.http.get(this.url)
      .subscribe({
        next: res => {
          this.list = res as Patients[];
        },
        error: err => { console.log(err)}
      })
  }

  postPatientDetail() {
    return this.http.post(this.url, this.formData)
  }

  putPatientDetail() {
    return this.http.put(this.url + '/' + this.formData.id, this.formData)
  }

  deletePatientDetail(id:number) {
    return this.http.delete(this.url + '/' + id)
  }

  resetForm(form: NgForm) {
    form.form.reset()
    this.formData = new Patients()
  }
}
