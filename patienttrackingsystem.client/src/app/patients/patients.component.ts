import { Component, OnInit} from '@angular/core';
import { PatientsService } from '../shared/patients.service';
import { Patients } from '../shared/patients.model';

@Component({
  selector: 'app-patients',
  standalone: false,
  templateUrl: './patients.component.html',
  styleUrl: './patients.component.css'
})
export class PatientsComponent implements OnInit {
  constructor(public service: PatientsService) {

  }
  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord: Patients) {
    this.service.formData = Object.assign({},selectedRecord);
  }

  onDelete(id: number) {
    this.service.deletePatientDetail(id)
      .subscribe({
        next: res => {
          this.service.list = res as Patients[]
        },
        error: err => { console.log(err) }
      })
  }
}
