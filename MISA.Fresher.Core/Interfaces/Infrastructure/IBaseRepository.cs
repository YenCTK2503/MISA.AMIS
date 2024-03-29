﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Interfaces.Infrastructure
{
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Thực hiện lấy tất cả bản ghi của bảng T
        /// </summary>
        /// <returns>Tất cả bản ghi</returns>
        /// createdBy: CTKimYen (15/12/2021)
        public IEnumerable<T> GetAll();

        /// <summary>
        /// Thực hiện lấy ra một đối tượng theo khóa chính
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>Đối tượng có khóa chính cần tìm</returns>
        /// createdBy: CTKimYen (15/12/2021)
        public T GetById(Guid entityId);

        /// <summary>
        /// Thực hiện thêm mới đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng</param>
        /// <returns>Số lượng bản ghi thêm mới thành công</returns>
        /// createdBy: CTKimYen (15/12/2021)
        public int Insert(T entity);

        /// <summary>
        /// Thực hiện Sửa một đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng</param>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>Số lượng bản ghi sửa thành công</returns>
        /// createdBy: CTKimYen (15/12/2021)
        public int Update(T entity, Guid entityId);

        /// <summary>
        /// Thực hiện xóa một đối tượng
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>Số lượng bản ghi xóa thành công</returns>
        /// createdBy: CTKimYen (15/12/2021)
        public int Delete(Guid entityId);

        /// <summary>
        /// Thực hiện kiểm tra giá trị thuộc tính của 1 đối tượng có tồn tại trong csdl
        /// </summary>
        /// <param name="propName">Tên thuộc tính</param>
        /// <param name="propValue">Giá trị của thuộc tính</param>
        /// <param name="entityId">Giá trị Khóa chính của đối tượng (nếu có)</param>
        /// <returns>true - đã tồn tại; false - chưa tồn tại</returns>
        public bool CheckExist(string propName, string propValue, string entityId);
        

    }
}
