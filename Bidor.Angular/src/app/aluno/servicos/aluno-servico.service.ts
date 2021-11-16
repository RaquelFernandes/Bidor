import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Aluno } from '../models/aluno';

@Injectable({
  providedIn: 'root'
})
export class AlunoServicoService {

  constructor(private httpClient: HttpClient) { }

  getAlunos(): Observable<Aluno[]>{
    const url = `${environment.api.url}/aluno`;
    return this.httpClient.get<Aluno[]>(url);
  }
}
