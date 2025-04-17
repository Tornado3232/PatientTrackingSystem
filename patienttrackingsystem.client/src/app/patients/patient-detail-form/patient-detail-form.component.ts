import { Component } from '@angular/core';
import { PatientsService } from '../../shared/patients.service';
import { NgForm } from '@angular/forms';
import { Patients } from '../../shared/patients.model';

@Component({
  selector: 'app-patient-detail-form',
  standalone: false,
  templateUrl: './patient-detail-form.component.html',
  styleUrl: './patient-detail-form.component.css'
})
export class PatientDetailFormComponent {
  constructor(public service: PatientsService) {
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.id == 0)
      this.insertRecord(form)
    else
      this.updateRecord(form)
  }

  insertRecord(form: NgForm) {
    this.service.postPatientDetail()
      .subscribe({
        next: res => {
          this.service.list = res as Patients[]
          this.service.resetForm(form)
          location.reload(); 
        },
        error: err => { console.log(err) }
      })
  }

  updateRecord(form: NgForm) {
    this.service.putPatientDetail()
      .subscribe({
        next: res => {
          this.service.list = res as Patients[]
          this.service.resetForm(form)
          location.reload();
        },
        error: err => { console.log(err) }
      })
  }

}
